template <typename T> void RegisterClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_CloudWebServices();
	RegisterModule_CloudWebServices();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_PerformanceReporting();
	RegisterModule_PerformanceReporting();

	void RegisterModule_Physics();
	RegisterModule_Physics();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_ImageConversion();
	RegisterModule_ImageConversion();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_GameCenter();
	RegisterModule_GameCenter();

	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

	void RegisterModule_TLS();
	RegisterModule_TLS();

}

class EditorExtension; template <> void RegisterClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterClass<Behaviour>(const char*);
class Animation; 
class Animator; template <> void RegisterClass<Animator>(const char*);
class AudioBehaviour; template <> void RegisterClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterClass<AudioSource>(const char*);
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; 
class BoxCollider2D; 
class CapsuleCollider2D; 
class CircleCollider2D; 
class CompositeCollider2D; 
class EdgeCollider2D; 
class PolygonCollider2D; 
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; template <> void RegisterClass<FlareLayer>(const char*);
class GUIElement; template <> void RegisterClass<GUIElement>(const char*);
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterClass<GUILayer>(const char*);
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; template <> void RegisterClass<Light>(const char*);
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterClass<MonoBehaviour>(const char*);
class NavMeshAgent; 
class NavMeshObstacle; 
class NetworkView; 
class OffMeshLink; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; 
class Skybox; 
class SortingGroup; 
class Terrain; 
class VideoPlayer; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterClass<UI::CanvasRenderer>(const char*);
class Collider; template <> void RegisterClass<Collider>(const char*);
class BoxCollider; template <> void RegisterClass<BoxCollider>(const char*);
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; 
class SphereCollider; 
class TerrainCollider; 
class WheelCollider; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleAnimator; 
class ParticleEmitter; 
class EllipsoidParticleEmitter; 
class MeshParticleEmitter; 
class ParticleSystem; 
class Renderer; template <> void RegisterClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; 
class MeshRenderer; template <> void RegisterClass<MeshRenderer>(const char*);
class ParticleRenderer; 
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; 
class SpriteShapeRenderer; 
class TilemapRenderer; 
class TrailRenderer; 
class Rigidbody; template <> void RegisterClass<Rigidbody>(const char*);
class Rigidbody2D; 
namespace TextRenderingPrivate { class TextMesh; } template <> void RegisterClass<TextRenderingPrivate::TextMesh>(const char*);
class Transform; template <> void RegisterClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterClass<UI::RectTransform>(const char*);
class Tree; 
class WorldAnchor; 
class WorldParticleCollider; 
class GameObject; template <> void RegisterClass<GameObject>(const char*);
class NamedObject; template <> void RegisterClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AssetImporterLog; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; 
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterClass<TextRendering::Font>(const char*);
class GameObjectRecorder; 
class LightProbes; 
class Material; template <> void RegisterClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterClass<Mesh>(const char*);
class Motion; 
class AnimationClip; 
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterClass<PreloadData>(const char*);
class RuntimeAnimatorController; template <> void RegisterClass<RuntimeAnimatorController>(const char*);
class AnimatorController; 
class AnimatorOverrideController; template <> void RegisterClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterClass<AudioClip>(const char*);
class Shader; template <> void RegisterClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterClass<Sprite>(const char*);
class SpriteAtlas; 
class SubstanceArchive; 
class TerrainData; 
class TextAsset; template <> void RegisterClass<TextAsset>(const char*);
class CGProgram; template <> void RegisterClass<CGProgram>(const char*);
class MonoScript; template <> void RegisterClass<MonoScript>(const char*);
class Texture; template <> void RegisterClass<Texture>(const char*);
class BaseVideoTexture; 
class MovieTexture; 
class WebCamTexture; 
class CubemapArray; 
class LowerResBlitTexture; template <> void RegisterClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterClass<Texture3D>(const char*);
class VideoClip; 
class GameManager; template <> void RegisterClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterClass<BuildSettings>(const char*);
class CloudWebServicesManager; template <> void RegisterClass<CloudWebServicesManager>(const char*);
class CrashReportManager; 
class DelayedCallManager; template <> void RegisterClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterClass<InputManager>(const char*);
class MasterServerInterface; template <> void RegisterClass<MasterServerInterface>(const char*);
class MonoManager; template <> void RegisterClass<MonoManager>(const char*);
class NavMeshProjectSettings; 
class NetworkManager; template <> void RegisterClass<NetworkManager>(const char*);
class PerformanceReportingManager; template <> void RegisterClass<PerformanceReportingManager>(const char*);
class Physics2DSettings; 
class PhysicsManager; template <> void RegisterClass<PhysicsManager>(const char*);
class PlayerSettings; template <> void RegisterClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterClass<ScriptMapper>(const char*);
class TagManager; template <> void RegisterClass<TagManager>(const char*);
class TimeManager; template <> void RegisterClass<TimeManager>(const char*);
class UnityAnalyticsManager; template <> void RegisterClass<UnityAnalyticsManager>(const char*);
class UnityConnectSettings; template <> void RegisterClass<UnityConnectSettings>(const char*);
class LevelGameManager; template <> void RegisterClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterClass<LightmapSettings>(const char*);
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterClass<RenderSettings>(const char*);
class RenderPassAttachment; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 72 non stripped classes
	//0. Rigidbody
	RegisterClass<Rigidbody>("Physics");
	//1. Unity::Component
	RegisterClass<Unity::Component>("Core");
	//2. EditorExtension
	RegisterClass<EditorExtension>("Core");
	//3. Collider
	RegisterClass<Collider>("Physics");
	//4. BoxCollider
	RegisterClass<BoxCollider>("Physics");
	//5. Behaviour
	RegisterClass<Behaviour>("Core");
	//6. Camera
	RegisterClass<Camera>("Core");
	//7. GameObject
	RegisterClass<GameObject>("Core");
	//8. GUIElement
	RegisterClass<GUIElement>("Core");
	//9. GUILayer
	RegisterClass<GUILayer>("Core");
	//10. Light
	RegisterClass<Light>("Core");
	//11. Shader
	RegisterClass<Shader>("Core");
	//12. NamedObject
	RegisterClass<NamedObject>("Core");
	//13. Material
	RegisterClass<Material>("Core");
	//14. Sprite
	RegisterClass<Sprite>("Core");
	//15. TextAsset
	RegisterClass<TextAsset>("Core");
	//16. Texture
	RegisterClass<Texture>("Core");
	//17. Texture2D
	RegisterClass<Texture2D>("Core");
	//18. RenderTexture
	RegisterClass<RenderTexture>("Core");
	//19. Transform
	RegisterClass<Transform>("Core");
	//20. UI::RectTransform
	RegisterClass<UI::RectTransform>("Core");
	//21. QualitySettings
	RegisterClass<QualitySettings>("Core");
	//22. GlobalGameManager
	RegisterClass<GlobalGameManager>("Core");
	//23. GameManager
	RegisterClass<GameManager>("Core");
	//24. Renderer
	RegisterClass<Renderer>("Core");
	//25. MeshFilter
	RegisterClass<MeshFilter>("Core");
	//26. Mesh
	RegisterClass<Mesh>("Core");
	//27. MonoBehaviour
	RegisterClass<MonoBehaviour>("Core");
	//28. Animator
	RegisterClass<Animator>("Animation");
	//29. AnimatorOverrideController
	RegisterClass<AnimatorOverrideController>("Animation");
	//30. RuntimeAnimatorController
	RegisterClass<RuntimeAnimatorController>("Animation");
	//31. UI::Canvas
	RegisterClass<UI::Canvas>("UI");
	//32. UI::CanvasGroup
	RegisterClass<UI::CanvasGroup>("UI");
	//33. UI::CanvasRenderer
	RegisterClass<UI::CanvasRenderer>("UI");
	//34. TextRenderingPrivate::TextMesh
	RegisterClass<TextRenderingPrivate::TextMesh>("TextRendering");
	//35. TextRendering::Font
	RegisterClass<TextRendering::Font>("TextRendering");
	//36. AudioClip
	RegisterClass<AudioClip>("Audio");
	//37. SampleClip
	RegisterClass<SampleClip>("Audio");
	//38. AudioListener
	RegisterClass<AudioListener>("Audio");
	//39. AudioBehaviour
	RegisterClass<AudioBehaviour>("Audio");
	//40. AudioSource
	RegisterClass<AudioSource>("Audio");
	//41. PreloadData
	RegisterClass<PreloadData>("Core");
	//42. Cubemap
	RegisterClass<Cubemap>("Core");
	//43. Texture3D
	RegisterClass<Texture3D>("Core");
	//44. Texture2DArray
	RegisterClass<Texture2DArray>("Core");
	//45. MeshRenderer
	RegisterClass<MeshRenderer>("Core");
	//46. LowerResBlitTexture
	RegisterClass<LowerResBlitTexture>("Core");
	//47. TagManager
	RegisterClass<TagManager>("Core");
	//48. GraphicsSettings
	RegisterClass<GraphicsSettings>("Core");
	//49. DelayedCallManager
	RegisterClass<DelayedCallManager>("Core");
	//50. InputManager
	RegisterClass<InputManager>("Core");
	//51. TimeManager
	RegisterClass<TimeManager>("Core");
	//52. BuildSettings
	RegisterClass<BuildSettings>("Core");
	//53. ResourceManager
	RegisterClass<ResourceManager>("Core");
	//54. RuntimeInitializeOnLoadManager
	RegisterClass<RuntimeInitializeOnLoadManager>("Core");
	//55. MasterServerInterface
	RegisterClass<MasterServerInterface>("Core");
	//56. NetworkManager
	RegisterClass<NetworkManager>("Core");
	//57. ScriptMapper
	RegisterClass<ScriptMapper>("Core");
	//58. PhysicsManager
	RegisterClass<PhysicsManager>("Physics");
	//59. MonoManager
	RegisterClass<MonoManager>("Core");
	//60. MonoScript
	RegisterClass<MonoScript>("Core");
	//61. AudioManager
	RegisterClass<AudioManager>("Audio");
	//62. PlayerSettings
	RegisterClass<PlayerSettings>("Core");
	//63. CloudWebServicesManager
	RegisterClass<CloudWebServicesManager>("CloudWebServices");
	//64. PerformanceReportingManager
	RegisterClass<PerformanceReportingManager>("PerformanceReporting");
	//65. UnityAnalyticsManager
	RegisterClass<UnityAnalyticsManager>("UnityAnalytics");
	//66. UnityConnectSettings
	RegisterClass<UnityConnectSettings>("UnityConnect");
	//67. FlareLayer
	RegisterClass<FlareLayer>("Core");
	//68. RenderSettings
	RegisterClass<RenderSettings>("Core");
	//69. LevelGameManager
	RegisterClass<LevelGameManager>("Core");
	//70. LightmapSettings
	RegisterClass<LightmapSettings>("Core");
	//71. CGProgram
	RegisterClass<CGProgram>("Core");

}
