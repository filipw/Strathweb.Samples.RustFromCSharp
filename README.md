# Example of invoking Rust code from C#

Sample code for the blog post [Calling Rust code from C#](https://strathweb.com/2023/06/calling-rust-code-from-csharp/).

### Prerequisites

1. Install [Rust](https://rustup.rs)
2. Install [.NET SDK](https://dotnet.microsoft.com/en-us/download)
3. Install [uniffi-bindgen-cs](https://github.com/NordSecurity/uniffi-bindgen-cs#how-to-install)
  * use version 0.2.0 to match the uniffi version we will use in the Rust code 
  * `cargo install uniffi-bindgen-cs --git https://github.com/NordSecurity/uniffi-bindgen-cs --tag v0.2.0 `

### Building

Build everything

```
build.sh
```

or first build the Rust library manually 

```
cd rust-lib
cargo build
```

followed by building the C# host

```
cd csharp-host
dotnet build
```

### Running

Now you can invoke the C# host, which calls into the Rust library

```
cd csharp-host
dotnet run
```