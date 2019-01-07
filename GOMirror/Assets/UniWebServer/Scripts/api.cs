using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


namespace UniWebServer
{
    [RequireComponent(typeof(EmbeddedWebServerComponent))]
    public class api : MonoBehaviour, IWebResource
    {

        //Smaple URL's
        // http://localhost:8079/api?switch=1
        // http://localhost:8079/api?anim=true
        // http://localhost:8079/api?text=A%20wunderfull%20day.
        // http://localhost:8079/api?status=Temperature:13°C


        public string path = "/api";

        EmbeddedWebServerComponent server;

        public GameObject mainscreen;
        public GameObject weatherscreen;
        public TextMesh Infotext;
        public TextMesh Statustext;
        public GameObject Animation;

        void Start ()
        {
            server = GetComponent<EmbeddedWebServerComponent>();
            server.AddResource(path, this);
        }

        public void HandleRequest(Request request, Response response)
        {
            string[] param = request.path.Split('=');

            if (param[0] == "/api?switch")
            {
                if (param[1] == "1")
                {
                    mainscreen.SetActive(false);
                    weatherscreen.SetActive(true);
                }
                else
                {
                    mainscreen.SetActive(true);
                    weatherscreen.SetActive(false);
                }
                response.statusCode = 200;
                response.message = "OK.";
                response.Write("{\"feedback\":\"switch done\"}");

            } else if (param[0] == "/api?anim")
            {
                if (param[1]=="true")
                {
                    Animation.SetActive(true);
                    response.Write("{\"feedback\":\"animation started\"}");
                }
                else
                {
                    Animation.SetActive(false);
                    response.Write("{\"feedback\":\"animation stopped\"}");
                }
                response.statusCode = 200;
                response.message = "OK.";
                

            } else if (param[0] == "/api?text")
            {
                Infotext.text = WWW.UnEscapeURL(param[1]).Replace("<br>", "\n");

                response.statusCode = 200;
                response.message = "OK.";
                response.Write("{\"feedback\":\"text updated\"}");

            } else if (param[0] == "/api?status")
            {
                Statustext.text = WWW.UnEscapeURL(param[1]).Replace("<br>", "\n");

                response.statusCode = 200;
                response.message = "OK.";
                response.Write("{\"feedback\":\"status updated\"}");

            } else 
            {
                response.statusCode = 200;
                response.message = "OK.";
                response.Write("{\"feedback\":\"unknown action\"}");
            }
        }

    }
}