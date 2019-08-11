﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Google.Cloud.Storage.V1;
using System.Diagnostics;
using Newtonsoft.Json;

namespace HelloWorld
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            string token = ReadSecret();
            Bot.Run(ReadSecret());
        }
        private static string ReadSecret()
        {
            if (!File.Exists(@"secret.json"))
            {
                Storage.DownloadObject("boardgame_recommend_secrets", "secret.json");
            }
            string secret = System.IO.File.ReadAllText(@"secret.json");
            Secret deserializedSecret = JsonConvert.DeserializeObject<Secret>(secret);
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development"){
                return deserializedSecret.development_bot_token;
            } else {
                return deserializedSecret.production_bot_token;
            }
        }
    }
}
