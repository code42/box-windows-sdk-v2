using Newtonsoft.Json;

namespace Box.V2.Models
{
    public class BoxExternalUserFolderCollaborationEventSource : BoxEntity
    {
        public const string FieldFolderId = "folder_id";
        public const string FieldFolderName = "folder_name";
        public const string FieldUserEmail = "user_email";
        public const string FieldParent = "parent";
        public const string FieldOwnedBy = "owned_by";

        /// <summary>
        /// The unique ID of the folder being collaborated on.
        /// </summary>
        [JsonProperty(PropertyName = FieldFolderId)]
        public override string Id { get; protected set; }

        /// <summary>
        /// The name of the folder being collaborated on.
        /// </summary>
        [JsonProperty(PropertyName = FieldFolderName)]
        public string Name { get; private set; }

        /// <summary>
        /// The email of the external user collaborating on the folder
        /// </summary>
        [JsonProperty(PropertyName = FieldUserEmail)]
        public string UserEmail { get; private set; }

        /// <summary>
        /// The parent folder of the folder being collaborated on.
        /// </summary>
        [JsonProperty(PropertyName = FieldParent)]
        public BoxFolder Parent { get; private set; }

        /// <summary>
        /// The user that owns this folder
        /// </summary>
        [JsonProperty(PropertyName = FieldOwnedBy)]
        public BoxUser OwnedBy { get; private set; }
    }
}
