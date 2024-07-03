        public static Vector3 SAVEDPOS = new();

        public static Vector3 GETVECTOR3POS()
        {
            float X = ReadFloat(Addresse.PlayerCoordX);
            float Y = ReadFloat(Addresse.PlayerCoordY);
            float Z = ReadFloat(Addresse.PlayerCoordZ);

            return new Vector3(X, Y, Z);
        }

        public static Vector2 GETVECTOR2MAPPOS()
        {
            float X = ReadFloat(Addresse.MapCoordX);
            float Y = ReadFloat(Addresse.MapCoordY);

            return new Vector2(X, Y);
        }

        public static async Task<bool> SETVECTOR3POS(Vector3 pos, bool maptp = false)
        {
            if (pos == Vector3.Zero)
            {
                return false;
            }

            if (maptp)
            {
                await Task.Delay(2000);
            }

            // WriteMemory(Addresse.PlayerCoordX, "float", "x");
            // WriteMemory(Addresse.PlayerCoordY, "float", "y");
            // WriteMemory(Addresse.PlayerCoordZ, "float", "z");

            return true;
        }
