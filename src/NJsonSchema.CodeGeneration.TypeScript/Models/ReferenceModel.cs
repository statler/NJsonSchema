using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJsonSchema.CodeGeneration.TypeScript.Models
{
    /// <summary>
    /// Contains information regarding a reference required for a class
    /// </summary>
    public class ReferenceModel
    {
        /// <summary>
        /// The class name
        /// </summary>
        public string ConstructorInterfaceType { get => $"{BaseName}"; }

        /// <summary>
        /// The interface name
        /// </summary>
        public string ReferencedInterface { get => $"I{BaseName}"; }

        /// <summary>
        /// The Reference name
        /// </summary>
        public string ReferenceName { get => $"{BaseName}Ref"; }

        /// <summary>
        /// The Class name
        /// </summary>
        public string ClassName { get => $"{BaseName}"; }

        /// <summary>
        /// The interface name
        /// </summary>
        private string BaseName { get; set; }

        /// <summary>
        /// Init with property
        /// </summary>
        /// <param name="property"></param>
        public ReferenceModel(PropertyModel property)
        {
            BaseName = property.Type.Replace("[","").Replace("]", "");
        }
    }
}
