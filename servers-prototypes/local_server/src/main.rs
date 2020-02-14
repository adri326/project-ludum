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

const BROADCAST_IP: &str = "10.228.157.255:7878"; // ETML's broadcast ip
const ARE_YOU_UP_SIGNAL: [u8; 1] = [5]; // Enquiry Control Character ( https://en.wikipedia.org/wiki/Enquiry_character )
const IM_UP_SIGNAL: [u8; 1] = [6]; // Acknowledgement Control Character ( https://en.wikipedia.org/wiki/Acknowledgement_(data_networks) )
const SERVER_UP_SIGNAL: [u8; 2] = [6, 0];
const SERVER_DOWN_SIGNAL: [u8; 2] = [6, 1];
const USER_INTERFACE_IP: &str = "127.0.0.1:7879";

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
    let mut server_ip;
    let local_udp = UdpSocket::bind("127.0.0.1:7878").unwrap(); // Warning: Err variant not catched
    local_udp.connect(USER_INTERFACE_IP).unwrap(); // Warning: Err variant not catched

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

    let (is_up, server_addr) = ask_if_serv_is_up();
    if is_up {
        server_ip = server_addr.unwrap();
        local_udp.send(&SERVER_UP_SIGNAL);
    } else {
        local_udp.send(&SERVER_DOWN_SIGNAL);
    }
}

fn ask_if_serv_is_up() -> (bool, Option<Ipv4Addr>) {
    let upd = UpdSocket::bind("127.0.0.1:7878").unwrap(); // Warning: Err variant not catched
    udp.connect(BROADCAST_IP).unwrap(); // Same
    udp.send(&ARE_YOU_UP_SIGNAL); // Warning here about not using the Result ouput
    let mut buf = [0; 1];
    let (len, src_sckt) = udp.recv_from(&mut buf).unwrap(); // Warning: Err variant not catched
    if len == 1 && buf == IM_UP_SIGNAL {
        return (true, Some(src_sckt));
    }
    (false, None)
}

fn exit<F: fmt::Display>(msg: F) {
    eprintln!("{}", msg);
    process::exit(1);
}
