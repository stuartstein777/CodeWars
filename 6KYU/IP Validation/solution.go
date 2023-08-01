package kata

import "net/netip"

func Is_valid_ip(ip string) bool {
	_, err := netip.ParseAddr(ip)

	return err == nil
}
