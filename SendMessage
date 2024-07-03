        public static void SendMessage(string title = "Error", string[] messages = null)
        {
            if (messages == null || messages.Length == 0)
            {
                messages = new string[] { "No messages provided." };
            }

            string joinedMessages = string.Join(" && echo ", messages);

            Process.Start(new ProcessStartInfo("cmd.exe", $"/c start cmd /C \"color 4 && title {title} && echo {joinedMessages} && timeout /t 60\"")
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            });
        }

SendMessage("Title", new string[] { "line 1", "line 2", "line 3" });
