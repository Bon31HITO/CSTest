interface IGraphicsEngine
{
    // 初期化と終了処理
    void Initialize(IntPtr windowHandle);
    void Shutdown();

    // フレーム管理
    void BeginFrame();
    void EndFrame();

    // 2Dおよび3D描画機能
    void DrawSprite(Sprite sprite);
    void DrawMesh(Mesh mesh);
    void DrawText(string text, float x, float y, int fontSize);

    void UploadToGPU(float[] vertices, int[] indices, PrimitiveType type);
    void DrawFromGPU();

    // シーン管理
    void RenderScene(Scene scene);

    // テクスチャ管理
    int LoadTexture(string filePath);
    void BindTexture(int textureId);
    void ReleaseTexture(int textureId);

    // カメラ制御
    void SetCamera(Camera camera);

    // ライティングとシェーダー
    void SetLight(Light light);
    void SetShader(Shader shader);

    // パーティクルシステム
    void DrawParticles(ParticleSystem particleSystem);

    // その他ユーティリティ
    void ClearScreen(float r, float g, float b, float a);
    void Present(); // 画面に表示
}
