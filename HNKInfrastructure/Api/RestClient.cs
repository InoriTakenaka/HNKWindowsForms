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
        private string url_;
        private JavaScriptSerializer serializer_;
    }
}
