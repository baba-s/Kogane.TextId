using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// テキスト ID を管理する値オブジェクト
    /// </summary>
    [Serializable]
    public struct TextId :
        IEquatable<TextId>,
        IComparable<TextId>
    {
        //================================================================================
        // 変数(SerializeField)
        //================================================================================
        [SerializeField] private string m_key;

        //================================================================================
        // プロパティ
        //================================================================================
        public string Key   => m_key;
        public string Value => OnFind?.Invoke( this ) ?? m_key;

        //================================================================================
        // プロパティ(static)
        //================================================================================
        public static IStringFormatter Formatter { get; set; } = new DefaultStringFormatter();

        public static Func<TextId, string> OnFind { get; set; }

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TextId( string key ) => m_key = key;

        /// <summary>
        /// TextId のテキストに書式を指定した文字列を返します
        /// </summary>
        public string FormatWith<T>( T arg1 ) => Formatter.Format( Value, arg1 );

        /// <summary>
        /// TextId のテキストに書式を指定した文字列を返します
        /// </summary>
        public string FormatWith<T1, T2>( T1 arg1, T2 arg2 ) => Formatter.Format( Value, arg1, arg2 );

        /// <summary>
        /// TextId のテキストに書式を指定した文字列を返します
        /// </summary>
        public string FormatWith<T1, T2, T3>( T1 arg1, T2 arg2, T3 arg3 ) => Formatter.Format( Value, arg1, arg2, arg3 );

        /// <summary>
        /// TextId のテキストに書式を指定した文字列を返します
        /// </summary>
        public string FormatWith<T1, T2, T3, T4>( T1 arg1, T2 arg2, T3 arg3, T4 arg4 ) =>
            Formatter.Format
            (
                Value, arg1, arg2, arg3,
                arg4
            );

        public bool Equals( TextId    other ) => EqualityComparer<string>.Default.Equals( Key, other.Key );
        public int  CompareTo( TextId other ) => string.Compare( Key, other.Key, StringComparison.Ordinal );

        public override bool   Equals( object other ) => other is TextId result && Equals( result );
        public override int    GetHashCode()          => EqualityComparer<string>.Default.GetHashCode( Key );
        public override string ToString()             => Key;

        //================================================================================
        // 関数(static)
        //================================================================================
        public static implicit operator string( TextId textId ) => textId.Value;

        public static bool operator ==( TextId left, TextId right ) => left.Key == right.Key;
        public static bool operator !=( TextId left, TextId right ) => left.Key != right.Key;
    }
}