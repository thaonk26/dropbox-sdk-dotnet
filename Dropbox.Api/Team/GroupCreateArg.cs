// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The group create arg object</para>
    /// </summary>
    public class GroupCreateArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupCreateArg> Encoder = new GroupCreateArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupCreateArg> Decoder = new GroupCreateArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupCreateArg" /> class.</para>
        /// </summary>
        /// <param name="groupName">Group name.</param>
        /// <param name="groupExternalId">The creator of a team can associate an arbitrary
        /// external ID to the group.</param>
        /// <param name="groupManagementType">Whether the team can be managed by selected
        /// users, or only by team admins</param>
        public GroupCreateArg(string groupName,
                              string groupExternalId = null,
                              Dropbox.Api.TeamCommon.GroupManagementType groupManagementType = null)
        {
            if (groupName == null)
            {
                throw new sys.ArgumentNullException("groupName");
            }

            this.GroupName = groupName;
            this.GroupExternalId = groupExternalId;
            this.GroupManagementType = groupManagementType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupCreateArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupCreateArg()
        {
        }

        /// <summary>
        /// <para>Group name.</para>
        /// </summary>
        public string GroupName { get; protected set; }

        /// <summary>
        /// <para>The creator of a team can associate an arbitrary external ID to the
        /// group.</para>
        /// </summary>
        public string GroupExternalId { get; protected set; }

        /// <summary>
        /// <para>Whether the team can be managed by selected users, or only by team
        /// admins</para>
        /// </summary>
        public Dropbox.Api.TeamCommon.GroupManagementType GroupManagementType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupCreateArg" />.</para>
        /// </summary>
        private class GroupCreateArgEncoder : enc.StructEncoder<GroupCreateArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupCreateArg value, enc.IJsonWriter writer)
            {
                WriteProperty("group_name", value.GroupName, writer, enc.StringEncoder.Instance);
                if (value.GroupExternalId != null)
                {
                    WriteProperty("group_external_id", value.GroupExternalId, writer, enc.StringEncoder.Instance);
                }
                if (value.GroupManagementType != null)
                {
                    WriteProperty("group_management_type", value.GroupManagementType, writer, Dropbox.Api.TeamCommon.GroupManagementType.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupCreateArg" />.</para>
        /// </summary>
        private class GroupCreateArgDecoder : enc.StructDecoder<GroupCreateArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupCreateArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupCreateArg Create()
            {
                return new GroupCreateArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupCreateArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group_name":
                        value.GroupName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "group_external_id":
                        value.GroupExternalId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "group_management_type":
                        value.GroupManagementType = Dropbox.Api.TeamCommon.GroupManagementType.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
