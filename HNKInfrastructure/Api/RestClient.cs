using HNKCore.Proto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace HNKInfrastructure.Api {
    public class RestClient {
        public RestClient(string url) {
            url_ = url;
            serializer_ = new JavaScriptSerializer();
        }
        public ResponseModel RequestGet(string actionName, Hashtable hashtable) {
            string targeturl_ = url_ + actionName;
            ResponseModel response_ = new ResponseModel();
            try {

                List<string> list_ = new List<string>();
                if (hashtable != null) {
                    foreach (DictionaryEntry de in hashtable) {
                        list_.Add($"{de.Key}={de.Value}");
                    }
                }
                var resp_ = HttpGet(targeturl_, string.Join("&", list_.ToArray()));
                resp_ = HttpUtility.HtmlDecode(resp_);
                if (!string.IsNullOrEmpty(resp_)) {
                    response_ = serializer_.Deserialize<ResponseModel>(resp_);
                    string type = (response_.Data).GetType().FullName;
                }
            }
            catch (WebException ex) {
                response_.Message = ex.Message;
            }
            catch (Exception ex) {
                response_.Message = ex.Message;
            }
            return response_;
        }
        public ResponseModel RequestPut(string actionName,Object payload) {
            ResponseModel response = new ResponseModel();
            try {
                string reqUrl = url_ + actionName;
                string responseContent = HttpPut(reqUrl, serializer_.Serialize(payload));
                responseContent = HttpUtility.HtmlDecode(responseContent);
                if (!string.IsNullOrEmpty(responseContent)) {
                    response = serializer_.Deserialize<ResponseModel>(responseContent);
                }
            }catch(WebException ex) {
                response.Message = ex.Message;
            }catch(Exception ex) {
                response.Message = ex.Message;
            }
            return response;
        }
        public ResponseModel RequestPost(string actionName,object payload) {
            ResponseModel response = new ResponseModel();
            try {
                string targetUrl = url_ + actionName;
                string responseContent = HttpPost(targetUrl, serializer_.Serialize(payload));
                if (!string.IsNullOrEmpty(responseContent)) {
                    response = serializer_.Deserialize<ResponseModel>(responseContent);
                }
            }
            catch (WebException ex) {
                response.Message = ex.Message;
            }catch(Exception ex) {
                response.Message = ex.Message;
            }
            return response;
        }

        protected string HttpGet(string url, string content) {
            string retString = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (content == "" ? "" : "?") + content);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream myResponseStream = response.GetResponseStream()) {
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8)) {
                    retString = myStreamReader.ReadToEnd();
                }
            }
            return retString;
        }
        protected string HttpPut(string url,string content) {
            string result = string.Empty;
            string error = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try {
                request.Method = "PUT";
                request.Timeout = 5000;
                request.ContentType = "application/json";
                byte[] buffer = Encoding.UTF8.GetBytes(content);
                request.ContentLength = buffer.Length;
                using (Stream stream = request.GetRequestStream()) {
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream reciveStream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(reciveStream, Encoding.UTF8)) {
                    Char[] read = new Char[256];
                    int count = reader.Read(read, 0, 256);
                    while (count > 0) {
                        string tmp = new string(read, 0, count);
                        result += tmp;
                        count = reader.Read(read, 0, 256);
                    }
                }
            }
            catch (WebException ex) {
                error = $"HTTP_ERROR::web exception rised !:{ex.Message}";
                throw ex;
            }catch(Exception ex) {
                error = $"HTTP_ERROR::exception rised !:{ex.Message}";
                throw ex;
            }
            Console.WriteLine(error);
            return result;
        }
        protected string HttpPost(string url,string content) {
            string result = string.Empty;
            string error = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            try {
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Timeout = 5000;
                byte[] buffer = Encoding.UTF8.GetBytes(content);
                request.ContentLength = buffer.Length;
                using (Stream stream = request.GetRequestStream()) {
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Close();
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream reciveStream = response.GetResponseStream();
                using (StreamReader reader = new StreamReader(reciveStream, Encoding.UTF8)) {
                    Char[] read = new Char[256];
                    int count = reader.Read(read, 0, 256);
                    while (count > 0) {
                        string tmp = new string(read, 0, count);
                        result += tmp;
                        count = reader.Read(read, 0, 256);
                    }
                }
            }
            catch (WebException ex) {
                error = $"HTTP_ERROR::web exception rised !:{ex.Message}";
                throw ex;
            }
            catch (Exception ex) {
                error = $"HTTP_ERROR::exception rised !:{ex.Message}";
                throw ex;
            }
            Console.WriteLine(error);
            return result;
        }
        private string url_;
        protected JavaScriptSerializer serializer_ { get; }
    }
}
