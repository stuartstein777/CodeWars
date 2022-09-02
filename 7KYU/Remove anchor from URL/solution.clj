(ns kata
  (require [clojure.string :as str]))

(defn remove-url-anchor [url]
  (let [anchor-location (str/index-of url "#")]
    (if (nil? anchor-location)
      url
      (subs url 0 (str/index-of url "#")))))