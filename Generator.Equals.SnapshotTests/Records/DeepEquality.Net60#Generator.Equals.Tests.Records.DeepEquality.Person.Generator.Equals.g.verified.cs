﻿//HintName: Generator.Equals.Tests.Records.DeepEquality.Person.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

namespace Generator.Equals.Tests.Records
{
    partial class DeepEquality
    {
        partial record Person
        {
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public virtual bool Equals(global::Generator.Equals.Tests.Records.DeepEquality.Person? other)
            {
                return
                    !ReferenceEquals(other, null) && EqualityContract == other.EqualityContract
                    && global::Generator.Equals.DefaultEqualityComparer<global::System.Int32>.Default.Equals(this.Age!, other.Age!)
                    ;
            }
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override int GetHashCode()
            {
                var hashCode = new global::System.HashCode();
                
                hashCode.Add(this.EqualityContract);
                hashCode.Add(
                    this.Age!,
                    global::Generator.Equals.DefaultEqualityComparer<global::System.Int32>.Default);
                
                return hashCode.ToHashCode();
            }
        }
    }
}
