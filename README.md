# simple-http-server [![NuGet Status](http://img.shields.io/nuget/v/Exira.SimpleHttpServer.svg?style=flat)](https://www.nuget.org/packages/Exira.SimpleHttpServer/)

When doing webdevelopment, sometimes you need to serve files from an HTTP host instead of using the filesystem.

Since setting up a webserver is too much overhead, we quickly wrote something to serve static files on a given port.

It is based on OWIN. If you can use it, enjoy!

## Usage

`simple-http-server --port <port to listen on> --path <root path to serve>`

## Cloning

`git clone git@github.com:exira/simple-http-server.git -c core.autocrlf=input`

## Copyright

Copyright © 2014-2015 Cumps Consulting BVBA / Exira and contributors.

## License

simple-http-server is licensed under [BSD (3-Clause)](http://choosealicense.com/licenses/bsd-3-clause/ "Read more about the BSD (3-Clause) License"). Refer to [LICENSE.txt](https://github.com/exira/simple-http-server/blob/master/LICENSE.txt) for more information.
