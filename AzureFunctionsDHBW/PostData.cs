using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionsDHBW
{
    class PostData
    {
        bool isNew;
        string sessionId, applicationId, user, type, requestId, name, locale, timestamp, playerActivity;

        public bool IsNew { get; set; }
        public string SessionId { get; set; }
        public string ApplicationId { get; set; }
        public string User { get; set; }
        public string Type { get; set; }
        public string RequestId { get; set; }
        public string Name { get; set; }
        public string Locale { get; set; }
        public string Timestamp { get; set; }
        public string PlayerActivity { get; set; }
        
    }
}



/*
 {
  "session": {
    "new": true,
    "sessionId": "SessionId.e39e3530-d38f-4ff5-9225-d2ef4f3fe7c2",
    "application": {
      "applicationId": "amzn1.ask.skill.83fbc89f-b0ee-4b56-b22a-25c3306a5071"
    },
    "attributes": {},
    "user": {
      "userId": "amzn1.ask.account.AGVK3YWVHQX2RX6DSKW5HA2JJB3IUZ3LYTM2PPFRQUHZCR2EJM5MCEHFSOFYF7VWCDPFYAJFHSADPX5FVV5JIZ7FF7RPM7URI3CPHBSWVXZBZFOOLANCHHDPWFWM66XDUCI4YPRUK2LPNS6J5XL3FKRSW2P7DBAVEPQI4ZILCDHQXETVCCUJUHQOUGVM7GWNIU3LVJFDMSGE3LA"
    }
  },
  "request": {
    "type": "IntentRequest",
    "requestId": "EdwRequestId.9cd09d4b-eb9a-4015-96ce-081deeb7841f",
    "intent": {
      "name": "GetVorlesungTodayIntent",
      "slots": {}
    },
    "locale": "de-DE",
    "timestamp": "2018-03-07T09:15:35Z"
  },
  "context": {
    "AudioPlayer": {
      "playerActivity": "IDLE"
    },
    "System": {
      "application": {
        "applicationId": "amzn1.ask.skill.83fbc89f-b0ee-4b56-b22a-25c3306a5071"
      },
      "user": {
        "userId": "amzn1.ask.account.AGVK3YWVHQX2RX6DSKW5HA2JJB3IUZ3LYTM2PPFRQUHZCR2EJM5MCEHFSOFYF7VWCDPFYAJFHSADPX5FVV5JIZ7FF7RPM7URI3CPHBSWVXZBZFOOLANCHHDPWFWM66XDUCI4YPRUK2LPNS6J5XL3FKRSW2P7DBAVEPQI4ZILCDHQXETVCCUJUHQOUGVM7GWNIU3LVJFDMSGE3LA"
      },
      "device": {
        "supportedInterfaces": {}
      }
    }
  },
  "version": "1.0"
}*/
