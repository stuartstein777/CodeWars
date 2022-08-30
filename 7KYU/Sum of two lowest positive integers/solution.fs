let sumTwoSmallestNumbers numbers = numbers |> Seq.sort
                                            |> Seq.take 2
                                            |> Seq.sum