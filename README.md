# AOT compilation error when using Microsoft.Maui.Essentials library for iOS

The solution has three configurations:
- Debug (uses the Microsoft.Maui.Essentials 8.0.0-preview.3.8149 NuGet package)
- ReleaseError (uses the Microsoft.Maui.Essentials 8.0.0-preview.3.8149 NuGet package)
- Release (uses the UseMauiEssentials build property)

The result obtained while trying to generate an IPA for iOS devices is as followed:

### Debug
IPA is generated and working.

### ReleaseError
Error during compilation:

Failed to AOT compile Microsoft.Maui.dll, the AOT compiler exited with code 1

Failed to AOT compile Microsoft.Maui.Controls.dll, the AOT compiler exited with code 1

### Release
IPA is generated and working.

# Step to reproduce

- Update the bundle id name
- Provide your signing key and profile
- Build IPA
