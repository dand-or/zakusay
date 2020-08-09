FROM mcr.microsoft.com/dotnet/core/runtime:3.1

RUN apt-get update \
    && apt-get install -y \
    vim \
    locales \
    locales-all

ADD ./etc/locale.gen /etc/locale.gen

RUN locale-gen \
    update-locale

COPY bin/Release/netcoreapp3.1/linux-x64/publish/ App/
WORKDIR App/
ENTRYPOINT ["zakusay"]