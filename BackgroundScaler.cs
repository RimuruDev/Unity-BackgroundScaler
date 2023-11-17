// Resharper disable all
// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub    Organizations: https://github.com/Rimuru-Dev
//          - Gists:    https://gist.github.com/RimuruDev/61e9f0111b35d3e67ef18fab611d7595
// **************************************************************** //

using UnityEngine;

namespace RimuruDev
{
    [SelectionBase]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(SpriteRenderer))]
    [HelpURL("https://github.com/RimuruDev/Unity-BackgroundScaler")]
    public sealed class BackgroundScaler : MonoBehaviour
    {
        [SerializeField] private Camera cameraRenderer;
        private SpriteRenderer backgroundSpriteRenderer;

        private void Awake() =>
            backgroundSpriteRenderer = GetComponent<SpriteRenderer>();

        private void Start() =>
            ScaleBackground();

        private void LateUpdate() =>
            ScaleBackground();

        private void ScaleBackground()
        {
            var targetHeight = cameraRenderer.orthographicSize * 2;
            var targetWidth = targetHeight * Screen.width / Screen.height;

            var backgroundSize = backgroundSpriteRenderer.sprite.bounds.size;
            
            var targetScale = Vector3.one;
            
            var widthRatio = targetWidth / backgroundSize.x;
            var heightRatio = targetHeight / backgroundSize.y;

            if (widthRatio > heightRatio)
                targetScale *= widthRatio;
            else
                targetScale *= heightRatio;

            transform.localScale = targetScale;
        }
    }
}