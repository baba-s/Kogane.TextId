using TMPro;

namespace Kogane
{
    /// <summary>
    /// TMP_Text 型の拡張メソッドを管理するクラス
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class TMP_TextTextIdExtensionMethods
    {
        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// TextId に紐づくテキストを設定します
        /// </summary>
        public static void SetText
        (
            this TMP_Text self,
            TextId        textId
        )
        {
            self.text = textId.Value;
        }

        /// <summary>
        /// TextId に紐づくテキストを設定します
        /// </summary>
        public static void SetText<T>
        (
            this TMP_Text self,
            TextId        textId,
            T             arg1
        )
        {
            self.text = textId.FormatWith( arg1 );
        }

        /// <summary>
        /// TextId に紐づくテキストを設定します
        /// </summary>
        public static void SetText<T1, T2>
        (
            this TMP_Text self,
            TextId        textId,
            T1            arg1,
            T2            arg2
        )
        {
            self.text = textId.FormatWith( arg1, arg2 );
        }

        /// <summary>
        /// TextId に紐づくテキストを設定します
        /// </summary>
        public static void SetText<T1, T2, T3>
        (
            this TMP_Text self,
            TextId        textId,
            T1            arg1,
            T2            arg2,
            T3            arg3
        )
        {
            self.text = textId.FormatWith( arg1, arg2, arg3 );
        }

        /// <summary>
        /// TextId に紐づくテキストを設定します
        /// </summary>
        public static void SetText<T1, T2, T3, T4>
        (
            this TMP_Text self,
            TextId        textId,
            T1            arg1,
            T2            arg2,
            T3            arg3,
            T4            arg4
        )
        {
            self.text = textId.FormatWith( arg1, arg2, arg3, arg4 );
        }
    }
}