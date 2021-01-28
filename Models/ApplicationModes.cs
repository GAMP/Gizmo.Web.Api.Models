using System;
using System.Runtime.Serialization;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Application modes.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationModes
    {
        /// <summary>
        /// Single player.
        /// </summary>
        [DataMember]
        public bool SinglePlayer { get; set; }

        /// <summary>
        /// Online multiplayer.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        public bool Online { get; set; }

        /// <summary>
        /// Lan Multiplayer.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        public bool Multiplayer { get; set; }

        /// <summary>
        /// Settings.
        /// </summary>
        [DataMember]
        public bool Settings { get; set; }

        /// <summary>
        /// Utility.
        /// </summary>
        [DataMember]
        public bool Utility { get; set; }

        /// <summary>
        /// Game.
        /// </summary>
        [DataMember]
        public bool Game { get; set; }

        /// <summary>
        /// Application.
        /// </summary>
        [DataMember]
        public bool Application { get; set; }

        /// <summary>
        /// Free to play.
        /// </summary>
        [DataMember]
        public bool FreeToPlay { get; set; }

        /// <summary>
        /// Requires subscription.
        /// </summary>
        [DataMember]
        public bool RequiresSubscription { get; set; }

        /// <summary>
        /// Free trial.
        /// </summary>
        [DataMember]
        public bool FreeTrial { get; set; }

        /// <summary>
        /// Split screen.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        public bool SplitScreenMultiPlayer { get; set; }

        /// <summary>
        /// Lan co-op.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        public bool CoOpLan { get; set; }

        /// <summary>
        /// Online co-op.
        /// </summary>
        //[IsGameModeAttibute()]
        [DataMember]
        public bool CoOpOnline { get; set; }

        /// <summary>
        /// One time purchase.
        /// </summary>
        [DataMember]
        public bool OneTimePurchase { get; set; }
    }
}