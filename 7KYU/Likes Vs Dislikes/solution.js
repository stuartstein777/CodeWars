// Like, Dislike, Nothing come from Preloaded
const likeOrDislike = (buttons) => buttons.reduce((acc, i) => acc === i ? Nothing : i, Nothing);