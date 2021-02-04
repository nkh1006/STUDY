using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string sampleText = "This is sample text";

            // 해당문자열이 존재하는 확인 true, false
            string.IsNullOrEmpty(sampleText);

            // Contain 문자열안에 해당 문자열이 존재하는 확인 true, false
            var sampleText1 = sampleText.Contains("sample").ToString();

            // Equals 특정문자열과 해당 문자열이 같은지 확인 true, false
            var sampleText2 = sampleText.Equals("This is sample text1").ToString();

            // Length 해당 문자열의 길이값을 반환
            var sampleText3 = sampleText.Length.ToString();

            // Replace 해당 문자열의 특정부분을 다른 문자열로 치환한다.
            var sampleText4 = sampleText.Replace("text", "image").ToString();

            // Split 해당 문자열을 특정 문자열로 나누어 배열형태로 반환해준다.
            var sampleText5 = sampleText.Split(" ");

            // Substring 특정 위치로 잘라준다. (시작인덱스, 이후 자를 인덱스길이)
            var sampleText6 = sampleText.Substring(3, 2);

            // ToLower 해당 문자열을 소문자로 반환
            var sampleText7 = sampleText.ToLower();

            // ToUpper 해당 문자열을 대문자로 반환
            var sampleText8 = sampleText.ToLower();

            // Trim 해당 문자열의 공백을 제거해준다.
            var sampleText9 = sampleText.Trim();

        }
    }
}
