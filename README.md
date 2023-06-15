# Example of invoking Rust code from C#

### Prerequisites

1. Install [Rust](https://rustup.rs)
2. Install [.NET SDK](https://dotnet.microsoft.com/en-us/download)
3. Install [uniffi-bindgen-cs](https://github.com/NordSecurity/uniffi-bindgen-cs#how-to-install)
  * use version 0.2.0 to match the uniffi version we will use in the Rust code 
  * `cargo install uniffi-bindgen-cs --git https://github.com/NordSecurity/uniffi-bindgen-cs --tag v0.2.0 `

### Building

```
cd rust-lib
cargo build
```

```
cd csharp-host
dotnet run
```