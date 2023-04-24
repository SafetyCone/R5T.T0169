using System;


namespace R5T.T0169
{
    public enum InstanceVarietyTarget
    {
        Type = 0,
        MethodsOfType,
        PropertiesOfType,
        /// <summary>
        /// For use with Documentation instances.
        /// </summary>
        StaticReadOnlyObjects
    }
}
