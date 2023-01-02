﻿//HintName: Generator.Equals.Tests.Classes.DeepEquality.Person.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

namespace Generator.Equals.Tests.Classes
{
    partial class DeepEquality
    {
        partial class Person : global::System.IEquatable<Person>
        {
            /// <summary>
            /// Indicates whether the object on the left is equal to the object on the right.
            /// </summary>
            /// <param name="left">The left object</param>
            /// <param name="right">The right object</param>
            /// <returns>true if the objects are equal; otherwise, false.</returns>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public static bool operator ==(
                global::Generator.Equals.Tests.Classes.DeepEquality.Person? left,
                global::Generator.Equals.Tests.Classes.DeepEquality.Person? right) =>
                global::Generator.Equals.DefaultEqualityComparer<global::Generator.Equals.Tests.Classes.DeepEquality.Person?>.Default
                    .Equals(left, right);
            
            /// <summary>
            /// Indicates whether the object on the left is not equal to the object on the right.
            /// </summary>
            /// <param name="left">The left object</param>
            /// <param name="right">The right object</param>
            /// <returns>true if the objects are not equal; otherwise, false.</returns>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public static bool operator !=(global::Generator.Equals.Tests.Classes.DeepEquality.Person? left, global::Generator.Equals.Tests.Classes.DeepEquality.Person? right) =>
                !(left == right);
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override bool Equals(object? obj)
            {
                var other = obj as global::Generator.Equals.Tests.Classes.DeepEquality.Person;
                return
                    !ReferenceEquals(other, null) && this.GetType() == other.GetType()
                    && global::Generator.Equals.DefaultEqualityComparer<global::System.Int32>.Default.Equals(this.Age!, other.Age!)
                    ;
            }
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public bool Equals(global::Generator.Equals.Tests.Classes.DeepEquality.Person? other) =>
                Equals((object?) other);
            
            
            /// <inheritdoc/>
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
            public override int GetHashCode()
            {
                var hashCode = new global::System.HashCode();
                
                hashCode.Add(this.GetType());
                hashCode.Add(
                    this.Age!,
                    global::Generator.Equals.DefaultEqualityComparer<global::System.Int32>.Default);
                
                return hashCode.ToHashCode();
            }
        }
    }
}
