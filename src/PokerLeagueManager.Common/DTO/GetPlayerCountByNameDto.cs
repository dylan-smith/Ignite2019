﻿using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using PokerLeagueManager.Common.Infrastructure;

namespace PokerLeagueManager.Common.DTO
{
    [DataContract]
    public class GetPlayerCountByNameDto : BaseDataTransferObject
    {
        [DataMember]
        [Description("Guid that uniquely identifies the player")]
        public Guid PlayerId { get; set; }

        [DataMember]
        public string PlayerName { get; set; }
    }
}
