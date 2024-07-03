        public static void SystemNoOutput(string command)
        {
            command = "/C " + command;

            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                Arguments = command,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            Process process = new Process()
            {
                StartInfo = startInfo
            };

            process.Start();
        }

SystemNoOutput("sc stop KProcessHacker3 >nul 2>&1"); // any .sys stop
