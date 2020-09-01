# zakusay

"zakusay" is an implementation by .NET Core which is a homage to "cowsay".

## Install

Get zakusay from Release and create symbolic link in anywhere you like.
1. Unzip to the appropriate path
2. Create symbolic link in anywhere you like.(Preferably in a place specified in $PATH such as /usr/local/bin)
   ```
   $ sudo ln -s /path/to/zakusay /usr/local/bin/zakusay
   ```
3. That's it! You can use the zakusay command as shown in the usage example.

## Usage

### basic
```
$ zakusay "this is ms06"

\ this is ms06 /
        _____
      /_|_|__\
      |__O__||
     ((([=]))))
```

### commander type option
```
$ zakusay -s "this is commander"

\ this is commander /
       _\____
      /_|\|__\
      |__@__||
     ((([=]))))
```

### another mobilesuit
```
$ zakusay -f dom hello

\ hello /
      ____
    _//  \_`.
   || @) _|| \
   /(\__//))))\
```

### show mobile suit list
```
$ zakusay -l
```

### show help
```
$ zakusay --help
```
