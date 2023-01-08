﻿//HintName: RecordStructSample.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

partial record struct RecordStructSample
{
    /// <inheritdoc/>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public bool Equals(global::RecordStructSample other)
    {
        return true
            && global::Generator.Equals.DefaultEqualityComparer<global::System.String>.Default.Equals(this.Name!, other.Name!)
            && global::Generator.Equals.DefaultEqualityComparer<global::System.Int32>.Default.Equals(this.Age!, other.Age!)
            ;
    }
    
    /// <inheritdoc/>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public override int GetHashCode()
    {
        var hashCode = new global::System.HashCode();
        
        hashCode.Add(
            this.Name!,
            global::Generator.Equals.DefaultEqualityComparer<global::System.String>.Default);
        hashCode.Add(
            this.Age!,
            global::Generator.Equals.DefaultEqualityComparer<global::System.Int32>.Default);
        
        return hashCode.ToHashCode();
    }
}
