// https://github.com/abock/goodbye-wordpress
// Copyright 2020 Aaron Bockover.
// Licensed under the MIT License.

using System;
using System.Collections.Immutable;

namespace Goodbye.WordPress
{
    public sealed record Post(
        int Id,
        DateTimeOffset? Published,
        DateTimeOffset? Updated,
        string Name,
        string Title,
        ImmutableList<string> Categories,
        ImmutableList<string> Tags,
        string AuthorName,
        string Content,
        ImmutableList<string> RedirectFrom,
        ImmutableList<PostResource> Resources);
}
