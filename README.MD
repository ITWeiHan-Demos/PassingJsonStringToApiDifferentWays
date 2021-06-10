# Passing Json string to asp.net web api different ways test demo

Q : Why this demo?
A : [c# - ASP.NET Core 3.1 Web Api HttpPost Action parameter can't receive axios application/json HttpPost passing data - Stack Overflow](https://stackoverflow.com/questions/67914467/asp-net-core-3-1-web-api-httppost-action-parameter-cant-receive-axios-applicati/67915046#67915046)


![image](https://user-images.githubusercontent.com/12729184/121471041-a0fa6d80-c9f1-11eb-90f9-823870be4781.png)


Because axios default `Content-Type: application/x-www-form-urlencoded`
it need to update `Content-Type': 'application/json`, or system'll show `415 unsupported media type`

![image](https://user-images.githubusercontent.com/12729184/121474462-b0c88080-c9f6-11eb-86d3-d4ab2e6905ad.png)


And then it can't use `string` type or system'll show `400 bad request`

![image](https://user-images.githubusercontent.com/12729184/121474267-6941f480-c9f6-11eb-8d74-e3fc114d6c7a.png)

Because asp.net core check `Content-Type': 'application/json` and use `[FromBody]` will auto convert to json object (`System.Text.Json.JsonElement`), so that's why it can't use string type.
![image](https://user-images.githubusercontent.com/12729184/121474964-68f62900-c9f7-11eb-84aa-32587f8f7033.png)
