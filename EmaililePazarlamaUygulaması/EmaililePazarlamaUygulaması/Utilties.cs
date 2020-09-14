using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace EmaililePazarlamaUygulaması
{
    public static class Utilties
    {
        public static string GetFilePath(string filePath)
        {
            char[] delims = new[] { '\r', '\n', '\\' };
            string fileName = filePath;
            string currentDirectory = Environment.CurrentDirectory;
            string changeDirectory = "";
            string[] directorySplit = currentDirectory.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < directorySplit.Length - 2; i++)
            {
                changeDirectory = changeDirectory + directorySplit[i] + '\\';
            }

            ;
            string path = System.IO.Path.Combine(changeDirectory, @"Data\", fileName);
            return path;
        }

        //List directory and return string array
        public static string[] ListDirectory(string path,bool files)
        {
            string[] filePaths;
            string directoryPath = GetFilePath(path);
            if (files)
            {
                filePaths = Directory.GetFiles(directoryPath);
            }
            else
            {
                filePaths = Directory.GetDirectories(directoryPath);
            }
            
            return filePaths;
        }

        //Check if file exists or create file and return file
        public static void CreateFile(string filePath)
        {
            string directoryPath = GetFilePath(filePath);
            if (!File.Exists(directoryPath))
            {
                File.Create(directoryPath);
            }
        }
        //File Write operation
        public static void WriteFile(string filePath, string str)
        {
            string directoryPath = GetFilePath(filePath);
            File.AppendAllText(directoryPath, str + Environment.NewLine);
        }

        //File Read operation
        public static string[] ReadFile(string filePath)
        {
            string directoryPath = GetFilePath(filePath);
            string[] lines = File.ReadAllLines(directoryPath);
            return lines;
        }

        //HTTP Request
        public static void SendEmail(string addresses, string subject, string code)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://makasapp.com/v1/email/offers");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    address = addresses,
                    subject = subject,
                    code = code
                });

                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }
    }
}
