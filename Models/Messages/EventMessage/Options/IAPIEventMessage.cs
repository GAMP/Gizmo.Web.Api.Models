﻿using MessagePack;

namespace Gizmo.Web.Api.Messaging
{
    [Union(1300, typeof(OptionsChangeEventMessage))]
    public partial interface IAPIEventMessage
    {
    }
}
