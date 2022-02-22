using MessagePack;
using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application modes.
    /// </summary>
    [Serializable]
    [DataContract]
    [MessagePackObject]
    public class ApplicationModes
    {
        /// <summary>
        /// Single player.
        /// </summary>
        [DataMember]
        [MessagePack.Key(0)]
        public bool SinglePlayer { get; set; }

        /// <summary>
        /// Online multiplayer.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        [MessagePack.Key(1)]
        public bool Online { get; set; }

        /// <summary>
        /// Lan Multiplayer.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        [MessagePack.Key(2)]
        public bool Multiplayer { get; set; }

        /// <summary>
        /// Settings.
        /// </summary>
        [DataMember]
        [MessagePack.Key(3)]
        public bool Settings { get; set; }

        /// <summary>
        /// Utility.
        /// </summary>
        [DataMember]
        [MessagePack.Key(4)]
        public bool Utility { get; set; }

        /// <summary>
        /// Game.
        /// </summary>
        [DataMember]
        [MessagePack.Key(5)]
        public bool Game { get; set; }

        /// <summary>
        /// Application.
        /// </summary>
        [DataMember]
        [MessagePack.Key(6)]
        public bool Application { get; set; }

        /// <summary>
        /// Free to play.
        /// </summary>
        [DataMember]
        [MessagePack.Key(7)]
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Requires subscription.
        /// </summary>
        [DataMember]
        [MessagePack.Key(8)]
        public bool RequiresSubscription { get; set; }

        /// <summary>
        /// Free trial.
        /// </summary>
        [DataMember]
        [MessagePack.Key(9)]
        public bool FreeTrial { get; set; }

        /// <summary>
        /// Split screen.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        [MessagePack.Key(10)]
        public bool SplitScreenMultiPlayer { get; set; }

        /// <summary>
        /// Lan co-op.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        [MessagePack.Key(11)]
        public bool CoOpLan { get; set; }

        /// <summary>
        /// Online co-op.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        [MessagePack.Key(12)]
        public bool CoOpOnline { get; set; }

        /// <summary>
        /// One time purchase.
        /// </summary>
        [DataMember]
        [MessagePack.Key(13)]
        public bool OneTimePurchase { get; set; }
    }
}