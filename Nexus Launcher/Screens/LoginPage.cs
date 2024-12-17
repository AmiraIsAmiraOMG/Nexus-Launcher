using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using System.Drawing;  // For working with images

namespace Nexus_Launcher.Screens
{
    public partial class LoginPage : UserControl
    {
        private const string clientId = "1312481188358918184"; // Your Discord application Client ID
        private const string clientSecret = "PA2fUqt9fMyBMg3JV2oO-ITuIrt9brSe"; // Your Discord application Client Secret
        private const string redirectUri = "http://localhost:4999/callback";  // Changed to port 4999

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            // Show the warning message box before proceeding with the login
            DialogResult dialogResult = MessageBox.Show(
                "ENCRYPTION ISN'T CURRENTLY USED IF YOU SUSPECT ANY MALWARE TO BE ON YOUR PC, DO NOT LOG IN.",
                "Security Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Cancel)
            {
                // If user clicks "Cancel", stop the login process
                return;
            }

            // If the user clicked "OK", continue with the login process
            try
            {
                // Step 1: Define the OAuth2 authorization URL with necessary scopes
                string authUrl = $"https://discord.com/oauth2/authorize?" +
                                 $"client_id={clientId}" +
                                 "&response_type=code" +
                                 $"&redirect_uri={Uri.EscapeDataString(redirectUri)}" +
                                 "&scope=identify+guilds+email+connections"; // Valid scopes

                // Debug information
                Console.WriteLine($"Authorization URL: {authUrl}");

                // Redirect the user to the Discord OAuth2 login
                Process.Start(new ProcessStartInfo(authUrl) { UseShellExecute = true });

                // Step 2: Start an HTTP listener to catch the redirect and authorization code
                var listener = new HttpListener();
                listener.Prefixes.Add(redirectUri + "/"); // Changed to use port 4999
                listener.Start();
                await Task.Run(() => listener.BeginGetContext(new AsyncCallback(HandleRedirect), listener));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in loginBtn_Click: {ex.Message}");
                MessageBox.Show($"Error starting the login process: {ex.Message}");
            }
        }

        private async void HandleRedirect(IAsyncResult result)
        {
            var listener = (HttpListener)result.AsyncState;

            try
            {
                var context = listener.EndGetContext(result);
                var code = context.Request.QueryString["code"];

                Console.WriteLine($"Authorization Code: {code}");

                if (string.IsNullOrEmpty(code))
                {
                    MessageBox.Show("Authorization code is missing or invalid.");
                    return;
                }

                // Respond to the user's browser with a message to close the tab
                string responseString = "<html><body>" +
                                        "<h2>You can close this tab now.</h2>" +
                                        "<p>If this tab doesn't close automatically, please manually close it.</p>" +
                                        "</body></html>";
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                context.Response.ContentLength64 = buffer.Length;
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.OutputStream.Close();

                // Stop the listener
                listener.Stop();

                // Step 3: Exchange the authorization code for an access token
                var client = new RestClient("https://discord.com/api/v10/oauth2/token");
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                request.AddParameter("client_id", clientId);
                request.AddParameter("client_secret", clientSecret);
                request.AddParameter("grant_type", "authorization_code");
                request.AddParameter("code", code);
                request.AddParameter("redirect_uri", redirectUri);

                var response = await client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var json = JObject.Parse(response.Content);
                    var accessToken = json["access_token"].ToString();
                    Console.WriteLine($"Access Token: {accessToken}");

                    // Step 4: Fetch user info using the access token
                    var userRequest = new RestRequest("https://discord.com/api/v10/users/@me", Method.Get);
                    userRequest.AddHeader("Authorization", $"Bearer {accessToken}");

                    var userResponse = await client.ExecuteAsync(userRequest);

                    if (userResponse.IsSuccessful)
                    {
                        var userInfo = JObject.Parse(userResponse.Content);
                        Console.WriteLine($"User Info: {userResponse.Content}");

                        var username = userInfo["username"].ToString();
                        SaveUsernameToFile(username);

                        var avatarHash = userInfo["avatar"].ToString();
                        var avatarUrl = $"https://cdn.discordapp.com/avatars/{userInfo["id"]}/{avatarHash}.png";
                        await SaveAvatarAsync(avatarUrl);

                        Invoke(new Action(() =>
                        {
                            label1.Text = $"Logged in as: {username}";
                            loginBtn.Text = " Re-Login With Discord";
                        }));
                    }
                    else
                    {
                        MessageBox.Show($"Failed to fetch user info.\nStatus: {userResponse.StatusCode}\nResponse: {userResponse.Content}");
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to exchange code for token.\nStatus: {response.StatusCode}\nResponse: {response.Content}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in HandleRedirect: {ex.Message}");
                MessageBox.Show($"Error during the authorization process: {ex.Message}");
            }
            finally
            {
                if (listener.IsListening)
                {
                    listener.Stop();
                }
            }
        }

        // Save the username to a file
        private void SaveUsernameToFile(string username)
        {
            try
            {
                // Define the path where you want to save the text file
                string filePath = Path.Combine(Application.StartupPath, "USER", "discord_username.txt");

                // Ensure the directory exists
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                // Write the username to the text file
                File.WriteAllText(filePath, username);

                Console.WriteLine($"Username '{username}' saved to file: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving username to file: {ex.Message}");
                MessageBox.Show($"An error occurred while saving the username: {ex.Message}");
            }
        }

        // Save the avatar image asynchronously
        private async Task SaveAvatarAsync(string avatarUrl)
        {
            try
            {
                var client = new HttpClient();
                var avatarData = await client.GetByteArrayAsync(avatarUrl);

                // Define the path to save the avatar image
                string avatarPath = Path.Combine(Application.StartupPath, "USER", "avatar.png");

                // Ensure the directory exists before saving the avatar
                Directory.CreateDirectory(Path.GetDirectoryName(avatarPath));

                // Use Task.Run to write the file asynchronously (since WriteAllBytes is synchronous)
                await Task.Run(() => File.WriteAllBytes(avatarPath, avatarData));

                Console.WriteLine($"Avatar saved to: {avatarPath}");

                // Update the PictureBox to display the new avatar on the UI thread
                Invoke(new Action(() =>
                {
                    if (File.Exists(avatarPath))
                    {
                        // Dispose of the old image to release the file lock
                        if (UserIcon.Image != null)
                        {
                            UserIcon.Image.Dispose();
                        }

                        // Load the new image
                        UserIcon.Image = Image.FromFile(avatarPath);
                    }
                }));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving avatar: {ex.Message}");
                MessageBox.Show($"An error occurred while saving the avatar: {ex.Message}");
            }
        }

    }
}
