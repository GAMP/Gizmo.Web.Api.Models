﻿using System.Collections.Generic;

namespace Gizmo.Web.Api.Models
{
    /// <summary>
    /// Top Users Report User Group.
    /// </summary>
    [MessagePack.MessagePackObject()]
    public class TopUsersReportUserGroupDTOModel
    {
        /// <summary>
        /// User Group Name.
        /// </summary>
        [MessagePack.Key(0)]
        public string? UserGroupName { get; set; }

        /// <summary>
        /// List of users within this group.
        /// </summary>
        [MessagePack.Key(1)]
        public List<TopUserInfoDTOModel> TopUsers { get; set; } = new List<TopUserInfoDTOModel>();
    }
}