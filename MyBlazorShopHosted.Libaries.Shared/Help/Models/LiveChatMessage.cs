﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MyBlazorShopHosted.Libaries.Shared.Help.Models
//{
//    public class LiveChatMessage
//    {
//        public string Message { get; }

//        public LiveChatTypeEnum Type { get; }

//        public string ClassName
//        {
//            get
//            {
//                switch (Type)
//                {
//                    case ALiveChatTypeEnum.SENT:
//                        return "sent";
//                    case LiveChatTypeEnum.RECEIVED:
//                        return "received";
//                }

//                return "";
//            }
//        }


//        public LiveChatMessage(string message, LiveChatTypeEnum type)
//        {
//            Message = message;
//            Type = type;
//        }
//    }
//}
