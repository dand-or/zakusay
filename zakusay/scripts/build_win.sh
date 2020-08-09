#!/bin/bash

prjdir=$( cd "$(dirname "${BASH_SOURCE[0]}")"; cd ..; pwd -P )

dotnet publish $prjdir -c Release -r win-x64 --self-contained true -p:PublishSingleFile=false -p:PublishTrimmed=true
