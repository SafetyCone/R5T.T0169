using System;


namespace R5T.T0169
{
    /// <summary>
    /// Targets like types, methods-on-types, etc.
    /// </summary>
    public enum InstanceVarietyTarget
    {
        Type = 0,
        MethodsOfType,
        /// <summary>
        /// Generate the higher-order type that a method would have if it was a property.
        /// </summary>
        MethodsAsProperties,
        PropertiesOfType,
        /// <summary>
        /// For use with Documentation instances.
        /// </summary>
        StaticReadOnlyObjects
    }
}
