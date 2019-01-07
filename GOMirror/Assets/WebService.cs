using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;
using UniWebServer;

[RequireComponent(typeof(EmbeddedWebServerComponent))]
public class WebService : MonoBehaviour
{

    public bool startOnAwake = true;
    public int port = 8079;
    public int workerThreads = 2;
    public bool processRequestsInMainThread = true;
    public bool logRequests = true;

    WebServer server;
    Dictionary<string, IWebResource> resources = new Dictionary<string, IWebResource>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
