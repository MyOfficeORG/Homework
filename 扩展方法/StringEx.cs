namespace 扩展方法
{
    using System;

    /// <summary>
    /// String扩展方法
    /// </summary>
    public static class StringEx
    {

        /// <summary>
        /// 验证字符串是否为手机号
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Boolean IsCellPhone(this String str)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(str, "^[1]{1}[0-9]{2}[0-9]{8}$");
        }

    }
}
