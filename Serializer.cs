using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Gizmo.Web.Api.Models
{
    public class Serializer
    {
        public void Serialize()
        {
            var p1 = new Product();
            p1.Id = 255;
            p1.Description = "Yes this is a pr";
            p1.Guid = Guid.NewGuid();
            p1.Cost = 44;
            MemoryStream stream = new MemoryStream();
            // Creates serializer.
            var serializer = MessagePackSerializer.Serialize(p1);

            stream.Seek(0, SeekOrigin.Begin);

            var unpackedObject = MessagePackSerializer.Deserialize<Product>(serializer);
        }
    }
}
