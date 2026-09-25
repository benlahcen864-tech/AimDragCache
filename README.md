# AimDragCache System (C# & Unity)

High-performance aim-drag caching and target prediction system converted to C# and JSON.

## Repository Architecture & Core Components

- **`HitboxConfig.json`**: Central JSON configuration for hitbox offsets and radii.
- **`HitboxManager.cs`**: Handles parsing and dynamic application of hitbox data.
- **`HitboxTargetPredictor.cs`**: Computes velocity-based target prediction vectors.
- **`AimDragController.cs`**: Manages user interaction and dragging physics.
- **`AimDragCacheManager.cs`**: Primary memory cache for rapid entity lookup.
- **`AimDragCacheSetup.cs`**: Automated setup routine for character game objects.
- **`AimDragSystemInitializer.cs`**: System bootstrap controller.
- **`AimDragConfigValidator.cs`**: Runtime data validation for collider dimensions.
- **`AimDragSmoothing.cs`**: Linear interpolation (Lerp) handler for aim movement.
