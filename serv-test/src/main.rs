use std::net::*;

fn main() {
    let udp = UdpSocket::bind("10.228.156.89:8081").unwrap();
    // udp.set_broadcast(true).unwrap();
    // udp.connect("10.228.157.255:8080").unwrap();


    udp.send_to(&[1,2,3,4], "10.228.157.255:8080").unwrap();

    // loop {
    //     println!("trying..");
    //     let mut buf = [0; 32];
    //     let (len, _) = udp.recv_from(&mut buf).unwrap();
    //     println!("result : {:?}", &buf[..len]);
    // }
}
