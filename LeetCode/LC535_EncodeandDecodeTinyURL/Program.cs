using LC535_EncodeandDecodeTinyURL;
using System;

Codec codec = new Codec();
string url = "https://leetcode.com/problems/design-tinyurl";

//codec.decode(codec.encode(url));

Console.WriteLine(codec.decode(codec.encode(url)));
