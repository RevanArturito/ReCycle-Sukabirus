using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthConsole
{
    internal static class FirestoreHelper
    {
        static string fireconfig = @" 
        {
            ""type"": ""service_account"",
            ""project_id"": ""recyclesukabirus"",
            ""private_key_id"": ""fbc59c93a274c734e68bae1c5d5dd00698223d86"",
            ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDIAh/puDrZeij6\n7ZhPNsXy4pGKLhjCUCJTqEY0Ng9eU50Byy/7joFMqg2kdyg5WlR6dIQ0MQO9//mT\nHDNFQOKSYAxd3NzI+1v7hI9zi0lB6YQWAU6aUQXB5pFUp93l12UrQEPoojvF31dz\nOYusPlwL5P/fyFbiVTokCb8D1x1RENYa+3zxLPuIHrsKvzNgqeLah/2MDAkvEDaj\nELmisswM/+W672cXDgP+QjJQGFLvXj0c99Be6zKlKTOdCZJmm2dkhD9L84/iG+rE\nlp0pR+wGIVXxByof0XEzAqVSmf9sq7wjdpLrfnqctmsn0UinRk75B/DCStVMeo6O\nO2ZueIGnAgMBAAECggEAHNwVn8NaFoRmgmKjPhbgtD3WE1K4dt1aPqkCzEjaqdk1\nyAr6FvnGlXnaMxeQgcoTc4H5i5BhAlr7t6rziPQmXUmnrymN4CBI8v97NYhtHyoj\nSYuRvHmhc4uh/82jGqWcbwO8aMZ0CobCFxnAGi/7VyoJc9B0HP+APq/7VIIHNGmQ\nY8FBTn8pOY+a8FoP6VP3EYw5ltDbPNfDPJChFpAQyAyS6pdCDBkl30bayrLk4AAx\nUSW4xqphdf37o2oqpkDGCQkCEs2OxYp1mZXqWoWvnHSGDdWJQbjOqH3RQBwjUyM8\n4tSCEfBLO7BhIJ2YsBqSC6F5KrvmZft1WLdh/+4BDQKBgQD54s/ULnGknPO8TnP0\nvwJxh06qYU7A3olCaK67xu5nY1DXZ+6774tDGkO6bczYHL4JGFcEzw+z0Ft47DDO\nNGWvlgBSTACVstBgwxmhalwQZaITwiy9x57SWE+WwqDSeMQNIxxJvUIaGvDbdtxl\n8xtg2vxOcuETBhmnMd6thyoWjQKBgQDM5uYEPcyGGRJthq3bvi1TpBroEll/Abxu\nZ9bTzEc4ON4znEsjV2UHq6300RKL+ayiRTggPn2DjwPos4g2w6AkH88x1XGPj8jZ\nM6al1iytNZa6p36ABLVBpzXfXZHONY0hHmQkfKNaBhfj4hk4eU7BSCQOznUA4Wt+\nR1lAVTq2AwKBgHBMKbHlHVUo47AgYaP/ow16DTQsfsPWPkEF4mCoycLUsyPapUL4\nJ9GEICPL7F7Cq/RSZ+jVVO0uGa2CF3zTt07tTj+twCWGMncJtp7/uVf1FJ1kic7P\nwuQso7fQx41OkGyG9tN8phQtP0ihZfK7CfbA8toebl+qQiUNGFFLiPKRAoGAMRB1\nMbzOlam5ROrEBONkHSwlmT6TmZsD0Pgic/LtduP/KSKax2qs8YpFjGLn6watNOoY\nR3hPO8pqKDWdP2fWl+/aAFfY6oSGlqQMmpdPeWZkomtrGiKGeKMefk78lAE0uyJ4\n3lfOEcd1vwar/V7m4ddxcu4zDDPuNn3FPGdsOJsCgYB4BwSJB2THMga+lKMQKuQW\ns36FbnOmAUOZVUIS8HbTF+zi14eF5gSY+raPr+RgManAy1YAKWylNW/wRlEF3kWJ\nILZxOOZnZyy4qltRLtLHo94l/UXxKADCxkHdy04r44ejyLjnRDkKzL89kWzVG35x\n4MMsNmptfZyISOek5Fyllg==\n-----END PRIVATE KEY-----\n"",
            ""client_email"": ""firebase-adminsdk-9lejm@recyclesukabirus.iam.gserviceaccount.com"",
            ""client_id"": ""100946090313848879457"",
            ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
            ""token_uri"": ""https://oauth2.googleapis.com/token"",
            ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
            ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-9lejm%40recyclesukabirus.iam.gserviceaccount.com"",
            ""universe_domain"": ""googleapis.com""
        }";

        static string filePath = "";

        public static FirestoreDb? Database { get; private set; }

        public static void SetEnvironmentVariable()
        {
            filePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filePath, fireconfig);
            File.SetAttributes(filePath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            Database = FirestoreDb.Create("recyclesukabirus");
            File.Delete(filePath);
        }
    }
}
