﻿using System;
using Core;
using TinyMessenger;

namespace Actor
{
    public class DoSomethingInner : TinyMessageBase,IDoSomethingInner
    {
        public DoSomethingInner(object sender) : base(sender)
        {
        }

        public int a { get; set; }
        public int b { get; set; }

        public Action<object> cb { get; set; }
    }
    public class DoSomethingInnerResponse : TinyMessageBase,IDoSomethingInnerResponse
    {
        public DoSomethingInnerResponse(object sender) : base(sender)
        {
        }
        public Action<object> cb { get; set; }
        public int Result { get; set; }

    }
}
