#!/bin/bash

dotnet publish .. -c Release -r osx-x64 --self-contained true -p:PublishSingleFile=false -p:PublishTrimmed=true
