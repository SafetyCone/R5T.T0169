using System;

using R5T.T0161;
using R5T.T0171;


namespace R5T.T0169
{
    public class InstanceVarietyDescriptor
    {
        public IAttributeTypeName MarkerAttributeTypeName { get; set; }
        public IInstanceVarietyName Name { get; set; }
        /// <summary>
        /// Allow multiple targets for an instance variety.
        /// </summary>
        public InstanceVarietyTarget[] Targets { get; set; }
    }
}
