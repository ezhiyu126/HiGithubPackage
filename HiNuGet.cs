using System;

namespace HiGithubPackage
{
    public class HiNuGet
    {
        /// <summary>
        /// 设置信息
        /// </summary>
        /// <param name="message"></param>
        public static void Hi(string message)
        {
            Console.WriteLine(string.IsNullOrWhiteSpace(message) ? "Hi GithubPackage ~" : message);

        }
    }
}
