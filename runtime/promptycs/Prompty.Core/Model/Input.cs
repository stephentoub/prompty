﻿namespace Prompty.Core;

/// <summary>
/// Represents an input for an Prompty file.
/// </summary>
public sealed class Input
{
    /// <summary>
    /// Gets or sets the type of the input.
    /// </summary>
    public PropertyType? Type { get; set; }

    /// <summary>
    /// Gets or sets the name of the input.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets a description of the input.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets a default value for the input.
    /// </summary>
    public object? Default { get; set; }

    /// <summary>
    /// Gets or sets whether the input is considered required (rather than optional).
    /// </summary>
    /// <remarks>
    /// The default is true.
    /// </remarks>
    public bool Required { get; set; } = true;

    /// <summary>
    /// Gets or sets JSON Schema describing this input.
    /// </summary>
    public object? JsonSchema { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to handle the input value as potential dangerous content.
    /// </summary>
    /// <remarks>
    /// The default is true.
    /// When set to false the value of the input is treated as safe content.
    /// </remarks>
    public bool Strict { get; set; } = true;

    /// <summary>
    /// Gets or sets a sample value for the input.
    /// </summary>
    public object? Sample { get; set; }
}
