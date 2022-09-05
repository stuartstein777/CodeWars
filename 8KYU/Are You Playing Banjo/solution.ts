export function areYouPlayingBanjo(name: string): string {
    if(name.toLowerCase().startsWith("r"))
      return name + " plays banjo";
    return name + " does not play banjo";
}