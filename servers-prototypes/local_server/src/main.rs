use std::{
    process,
    thread,
    fs,
    fmt,
    net::*,
    path::{
        PathBuf
    }
};
fn main() {
    let mut game_dir_path = PathBuf::new();
    game_dir_path.push(r"C:\");
    game_dir_path.push("ProgramData");
    game_dir_path.push("uno");
    let mut config_file_path = game_dir_path.clone();
    config_file_path.push("config.config");
    let config_file_raw;
    let mut game_path;
    let game_path_attr = "GamePath:";

    // Checks if the game directory exists and creates the missing director(y/ies) if they don't exists
    fs::create_dir_all(&game_dir_path); // Warning here about not using the Result ouput

    // Checks if the config file exists and creates it if not
    if !config_file_path.exists() || !config_file_path.is_file() {
        fs::write(&config_file_path, []); // Warning here about not using the Result ouput
    }

    match fs::read_to_string(&config_file_path) {
        Ok(content) => config_file_raw = content,
        Err(_) => {
            exit("An error occured while trying to read the game's config file");
            return;
        },
    }

    let mut config_file_contents = config_file_raw.split('\n');

    match config_file_contents.find(|&x| x.starts_with(&game_path_attr)) {
        Some(content) => game_path = content,
        None => {
            exit("An error occured while trying to get game path");
            return;
        },
    }

    match game_path.get(game_path_attr.len()..) {
        Some(path) => game_path = path,
        None => {
            exit("An error occured while trying to get game path (without attribute prefixing it)");
            return;
        },
    }

    process::Command::new(game_path).output(); // Warning here about not using the Result ouput
}

fn exit<F: fmt::Display>(msg: F) {
    eprintln!("{}", msg);
    process::exit(1);
}
