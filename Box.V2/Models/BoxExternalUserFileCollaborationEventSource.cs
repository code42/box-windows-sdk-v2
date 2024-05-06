using Newtonsoft.Json;

namespace Box.V2.Models
{
    public class BoxExternalUserFileCollaborationEventSource : BoxEntity
    {
        public const string FieldFileId = "file_id";
        public const string FieldFileName = "file_name";
        public const string FieldUserEmail = "user_email";
        public const string FieldParent = "parent";
        public const string FieldOwnedBy = "owned_by";

        /// <summary>
        /// The unique ID of the file being collaborated on.
        /// </summary>
        [JsonProperty(PropertyName = FieldFileId)]
        public override string Id { get; protected set; }

        /// <summary>
        /// The type of the object.
        /// </summary>
        public override string Type { get { return "file"; } protected set { return; } }

        /// <summary>
        /// The name of the file being collaborated on.
        /// </summary>
        [JsonProperty(PropertyName = FieldFileName)]
        public string Name { get; private set; }

        /// <summary>
        /// The email of the external user collaborating on the folder
        /// </summary>
        [JsonProperty(PropertyName = FieldUserEmail)]
        public string UserEmail { get; private set; }

        /// <summary>
        /// The parent folder of the file being collaborated on.
        /// </summary>
        [JsonProperty(PropertyName = FieldParent)]
        public BoxFolder Parent { get; private set; }

        /// <summary>
        /// The user that owns this file
        /// </summary>
        [JsonProperty(PropertyName = FieldOwnedBy)]
        public BoxUser OwnedBy { get; private set; }
    }
}
