// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Detected SSN details.
    /// </summary>
    public partial class SSN
    {
        /// <summary>
        /// Initializes a new instance of the SSN class.
        /// </summary>
        public SSN()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SSN class.
        /// </summary>
        /// <param name="text">Detected SSN in the input text content.</param>
        /// <param name="index">Index(Location) of the SSN in the input text
        /// content.</param>
        public SSN(string text = default(string), int? index = default(int?))
        {
            Text = text;
            Index = index;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets detected SSN in the input text content.
        /// </summary>
        [JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets index(Location) of the SSN in the input text content.
        /// </summary>
        [JsonProperty(PropertyName = "Index")]
        public int? Index { get; set; }

    }
}
