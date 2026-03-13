# Contributing to MimeTypes.NET

Thanks for contributing! This guide covers everything you need to add new MIME types or fix existing ones.

## Adding MIME types

### 1. Add the constant

Each MIME type category lives in its own file under `MimeTypes/`:

| Category | File |
|---|---|
| `application/*` | `MimeType.Application.cs` |
| `audio/*` | `MimeType.Audio.cs` |
| `font/*` | `MimeType.Font.cs` |
| `image/*` | `MimeType.Image.cs` |
| `multipart/*` | `MimeType.Multipart.cs` |
| `text/*` | `MimeType.Text.cs` |
| `video/*` | `MimeType.Video.cs` |

Add your constant in alphabetical order within its class, following this pattern:

```csharp
/// <summary>
/// image/jp2
/// </summary>
public const string Jp2 = Prefix + "jp2";
```

The XML doc comment is to provide richer contextual information for users, e.g. in IDE hover text.

### 2. Use consistent naming

- Constant names MUST reflect the MIME type subtype rather than be descriptive (e.g. `image/jp2` → `MimeType.Image.Jp2`, not `MimeType.Image.Jpeg2000`).
- Constant names MUST use PascalCase, in line with standard C# naming conventions.
- Punctuation characters such as `+`, `.` and `-` MUST be omitted and treated as a word break for PascalCase naming purposes (e.g. `svg+xml` → `SvgXml`, `vnd.microsoft.icon` → `VndMicrosoftIcon`).
- A digit at the start of a subtype name MUST be substituted with its English spelling (e.g. `3gpp` -> `Threegpp`).

#### Examples

| MIME type | Constant name |
|---|---|
| `image/jp2` | `Jp2` |
| `image/svg+xml` | `SvgXml` |
| `image/vnd.microsoft.icon` | `VndMicrosoftIcon` |
| `audio/3gpp` | `Threegpp` |

### 3. Add test coverage

Every constant MUST have a corresponding test in `MimeTypes.Tests/`. Add a `[TestCase]` line to the appropriate test file:

```csharp
[TestCase(MimeType.Image.Jp2, "image/jp2")]
```

Tests verify that the constant value exactly matches the expected MIME type string.

### 4. Reference a standard

Please reference an RFC or other authoritative source for the MIME type(s) you're adding in your PR description.

## Running the tests

```sh
dotnet test
```

## PR submission checklist

- [ ] Constants are named to match the MIME type value (not a descriptive name)
- [ ] Constants are in PascalCase
- [ ] Constants are in alphabetical order within their class
- [ ] Each new constant has an XML doc comment
- [ ] Each new constant is covered by a test case
- [ ] Each new constant is covered by an RFC or other authoritative source cited in the PR description
- [ ] 100% tests passing
